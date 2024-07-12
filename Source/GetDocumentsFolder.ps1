# Get the documents folder, regardless of whether the user profile points to the users folder on the OS drive or OneDrive
$documentsPath = [Environment]::GetFolderPath('MyDocuments')
Write-Output "DocPath= $documentsPath"
Write-Output $documentsPath | Out-File -FilePath "$(Get-Location)\DocumentsPath.txt"