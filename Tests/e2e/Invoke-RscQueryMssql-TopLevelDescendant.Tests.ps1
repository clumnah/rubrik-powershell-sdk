BeforeAll {
    . "$PSScriptRoot\e2eInit.ps1"
}
Describe -Name 'Invoke-RscQueryMssql -TopLevelDescendant' -Fixture {
    It -Name 'PhysicalHost' -Test {
        $physicalHostFields =
            Get-RscType -Name PhysicalHost -InitialProperties @(
                "id", 
                "name", 
                "physicalChildConnection.id"
            )
        $physicalHostFields.PhysicalChildConnection.Nodes = 
            Get-RscType -Name MssqlInstance -InitialProperties ("Id", "Name")
        $fields = Get-RscType -Name MssqlTopLevelDescendantTypeConnection
        $fields.nodes = $physicalHostFields
        $sqlObjects=Invoke-RscQueryMssql -TopLevelDescendant -Field $fields
        $sqlObjects.nodes | Should -Not -BeNullOrEmpty
    }
}