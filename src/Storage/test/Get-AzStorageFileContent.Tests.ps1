$TestRecordingFile = Join-Path 'C:\zd\azure-powershell\src\Storage\test' 'Get-AzStorageFileContent.Recording.json'
. (Join-Path $PSScriptRoot '..\generated\runtime' 'HttpPipelineMocking.ps1')

Describe 'Get-AzStorageFileContent' {
    It 'ShareName' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Share' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Directory' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'File' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}