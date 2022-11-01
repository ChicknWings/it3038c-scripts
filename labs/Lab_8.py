from bs4 import BeautifulSoup
import requests
import re

url = "https://www.britannica.com/topic/StarCraft"

result = requests.get(url)
doc = BeautifulSoup(result.text,"html.parser")

title = doc.find_all("title")
print(title)

for title in doc.find_all(re.compile("Star")):
    print(title)