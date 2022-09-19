function getInfo{
$IP = (get-netipaddress).ipv4address | Select-String "192*"
$env:USERNAME
$env:COMPUTERNAME
$Host.Version.Major
$DayofWeek = (Get-Date).DayofWeek
$Month = (Get-Date).Month
$Day = (Get-Date).Day
$Year = (Get-Date).Year
$String = $IP + $env:USERNAME
$Body = ("This machine's IP is $IP, User is $env:USERNAME. Hostname is $env:COMPUTERNAME. PowerShell Version" + $Host.Version.Major.ToString() + ". Today's Date is " + (Get-Date).DayofWeek.ToString()+ ", " +(Get-Date).Month.ToString()+"/" +(Get-Date).Day.ToString()+"/"+ (Get-Date).Year.ToString())
}





