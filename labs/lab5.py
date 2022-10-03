import datetime
while True:
    try:
        birthday = datetime.datetime.strptime(input("Please enter you Date of Birth:"), '%B %d %Y')
        break
    except:
        print("Please input as Month Day Year")

today = datetime.datetime.today()
timedelta = (tday - birthday).total_seconds()
print("You have been alive for:",timedelta,"seconds")
input("Press Any Key")



