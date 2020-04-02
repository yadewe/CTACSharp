$backupDir = "./../../TapTradeCSharpWrapper"

#检测目标路径是否存在，如果不存在则新建目标路径。
if (!(Test-Path -Path $backupDir))
{
    New-Item -ItemType directory -Path $backupDir
}

#备份bin目录的文件
#$binPath = "bin"
#Copy-Item -Path $binPath -Destination $backupDir -Recurse -Force
Copy-Item "./*.cs" $backupDir -Force

#$source = "./"
#Get-ChildItem $source -Include *.cs -Recurse |
#  #Where-Object { $_.PSIsContainer -eq $flase } |
#  Foreach-Object { robocopy $_.FullName $backupDir }