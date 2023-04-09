#get a list of australian nrl teams from an api
import requests
import json

url = 'https://www.thesportsdb.com/api/v1/json/1/search_all_teams.php?s=NRL'
r = requests.get(url)
data = r.json()

# print the list of teams
for team in data['teams']:
    print(team['strTeam'])