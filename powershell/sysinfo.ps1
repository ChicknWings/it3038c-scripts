function getIP{
    (get-netipaddress).ipv4address | Select-String "192*"
write-host(getIP)

}

$IP =  (get-netipaddress).ipv4address | Select-String "192*"
$Date = Get-Date
$Host_Version = $Host.Version.Major
$Host_Name = Get-WmiObject Win32_ComputerSystem | select Name
$Body = "This machine's IP is $IP. User is $env:username. Hostname is $Host_Name. Powershell Version is $Host_Version. Today's Date is $Date"


Write-Host($Body)


##Send-MailMessage -To "yang2sr@mail.uc.edu" -From "lingge120@gmail.com" -Subject "IT3038C Windows SysInfo" -Body $Body -SmtpServer smtp.gmail.com -port 587 -UseSSL -Credential (Get-Credential)