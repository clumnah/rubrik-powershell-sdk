﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json;
using RubrikSecurityCloud.NetSDK.Client;
using RubrikSecurityCloud.NetSDK.Client.Models.Authentication;
using RubrikSecurityCloud;
using RubrikSecurityCloud.Types;

namespace RubrikSecurityCloud.PowerShell.Private
{
    public class GqlTypeName
    {
        [JsonProperty("__typename")]
        public string TypeName { get; set; }
    }


    public class RscPSCmdlet : RscBasePSCmdlet
    {
        internal RscGraphQLClient _rbkClient;

        internal Dictionary<string, string> _validOperations = null;


        // _input is instantiated in BeginProcessing() here
        // and initialized in the Invoke methods in derived classes.
        internal RscCmdletInput _input = null;

        protected Dictionary<string, string> GetMetricTags()
        {
            string version =
                this
                    .MyInvocation
                    .MyCommand
                    .Module
                    .Version
                    .ToString();

            return new Dictionary<string, string>{
                {"Sdk-Caller", this._rbkClient.ClientName},
                {"Sdk-Language", "PowerShell"},
                {"Sdk-Rsc-Version", SchemaMeta.GraphqlSchemaVersion},
                {"Sdk-Version", version}
            };
        }

        protected override void BeginProcessing()
        {
            base.BeginProcessing();
            this._input = new RscCmdletInput(this);
            if (! this.GetInputs )
            {
                RetrieveConnection();
            }
        }

        protected override void EndProcessing()
        {
            base.EndProcessing();
        }

        protected void RetrieveConnection() 
        {
            try
            {
                this._rbkClient = (RscGraphQLClient)SessionState.PSVariable.GetValue("RscConnectionClient");

                //Check if the token has expired. If it has, attempt a new the session and return.
                if (this._rbkClient != null && _rbkClient.AuthenticationState == AuthenticationState.EXPIRED)
                {
                    Console.WriteLine("Client session expired, attempting to renew...");
                    Task AuthTask = _rbkClient.AuthAsync();
                    AuthTask.Wait();
                    if (this._rbkClient.AuthenticationState == AuthenticationState.AUTHORIZED)
                    {
                        Console.WriteLine("Client session renewed.");
                        return;
                    }
                }

                if (this._rbkClient == null || _rbkClient.AuthenticationState != AuthenticationState.AUTHORIZED)
                {
                    throw new Exception("No active session found. Use 'Connect-Rsc'. ");
                }
            }
            catch (Exception ex)
            {
                this._logger.Flush();
                var error = new ErrorRecord(
                    ex,
                    "RscConnectionClient",
                    ErrorCategory.ConnectionError,
                    null);
                ThrowTerminatingError(error);
            }
        }

        protected string GetSnappableTypeNameById(string id)
        {
            if (_rbkClient != null)
            {
                string query = @"
                        query HierarchyObjects($fids: [UUID!]!) {
                          hierarchyObjects(fids: $fids) {
                                id
                                __typename
                            }
                        }";

                OperationVariableSet variables = new OperationVariableSet
                {
                    Variables = new Dictionary<string, object>()
                    {
                        { "fids", (new List<string>{id}).ToArray() }
                    }
                };

                Task<List<GqlTypeName>> apiTask = _rbkClient.InvokeGenericCallAsync<List<GqlTypeName>>(query, variables);
                apiTask.Wait();
                List<GqlTypeName> response = apiTask.Result;

                if (response.Count > 0)
                {
                    return response[0].TypeName;
                }
                return null;
            }

            return null;
        }
    }
}

