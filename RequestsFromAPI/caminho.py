import requests
import json
import datetime 
import os
import pytz
from GetGames import GetGames



# URL para onde você vai enviar a solicitação POST
url = "http://localhost:5000/api/futebolvirtual/Games"



# Dados do post 

parametros = {
    'IdBet365': 3011684,
    'HomeTeam': 'Servia',
    'AwayTeam': 'Brasil',
    'SumScore': 1,
    'FinalTimeResult': '1-0',
    'HalfTimeResult': '0-0',
    'Date': '2024-01-03T14:07:00',
    'HomeImg': 'eu_7.png',
    'AwayImg': '19.png',
    'LeagueId': 123456
}

headers = {'Content-Type': 'application/json'}

# Realizar a solicitação POST com os dados milionarios

response = requests.post(url, data=json.dumps(parametros), headers=headers)


# Verificar o resultado da solicitação


# Verificar o resultado da solicitação
if response.status_code == 200:
    print("Solicitação POST bem-sucedida!")
    print(response.text)
else:
    print(f"Falha na solicitação POST. Código de status: {response.status_code}")
    print(response.text)


def GetResult():

	oldMatchId = ["","","",""]
	tip = {
			"Grupo":[],
			"Hora":[]
	}
	tipShot = [-1,-1,-1,-1]
	tipHour = ''
	tipAberta = False
	count_green = 0
	
	# leagues = ("Euro Cup","Super Liga Sul-Americana","Copa do Mundo","Premiership")
	# leagueSelector = 0

	group = 2

	while(True):
		config = requests.get ("http://localhost:5000/api/config",headers={'Authorization':'bearer eyJhbGciOiJIUzUxMiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6ImJvYiIsIm5hbWVpZCI6ImM3ZjJjN2NmLWZjOTctNDY2Yi04NDBhLTQ4MWRlMTI3ZTdjMCIsImVtYWlsIjoiYm9iQHRlc3QuY29tIiwibmJmIjoxNzA0MzgwNzkzLCJleHAiOjE3MDQ5ODU1OTMsImlhdCI6MTcwNDM4MDc5M30.fyoTLTUUABdd4J1EZxuGw4WWawsnop6KHg8wUR7oG5p1wNFoFaHKlcCnn-RqfEPOjo8tIHlDUYEM4ZxcjmvYbw'})
		cookie = config['configurationValue']

		#Shots
		number_shots=int(os.getenv('SHOTS_OVER_25'))

		tzBet365 = datetime.now(pytz.timezone('Europe/London'))
		dataGame = tzBet365.strftime('%Y-%m-%d')
		hourNow = tzBet365.strftime('%H:%M')

		lastGame = GetGames.GetGames(dataGame,hourNow,cookie)

		# Tentativa de correção de fechamento do console
		try:
			if(lastGame == False):
				print("Resultado não encontrado.")
				pass
		except:
				pass
		# hourNow = datetime(int(tzBet365.strftime('%Y')),int(tzBet365.strftime('%m')),int(tzBet365.strftime('%d')),int(tzBet365.strftime('%H')),int(tzBet365.strftime('%M')))


		# Declaração de variaveis locais
		pos = 0
		competition = ["","","",""]
		newMatchId = ["","","",""]
		matchHomeTeam = ["","","",""]
		matchAwayTeam = ["","","",""]
		matchFinalSumScore = ["","","",""]
		matchHalfResult = ["","","",""]
		matchFinalResult = ["","","",""]
		matchDate = ["","","",""]
		matchHour = ["","","",""]
		RED = "\033[1;31m"  
		BLUE = "\033[1;34m"
		CYAN = "\033[1;36m"
		GREEN = "\033[0;32m"
		RESET = "\033[0;0m"
		BOLD = "\033[;1m"
		REVERSE = "\033[;7m"
        
		# Laço de repetição para encontrar jogos
		try:
			for league in lastGame:

				# Populando arreys
				competition[pos] = league['competition']
				newMatchId[pos] = league['matches'][0]['Id']
				matchHomeTeam[pos] = league['matches'][0]['TeamHome']
				matchAwayTeam[pos] = league['matches'][0]['TeamAway']
				matchFinalSumScore[pos] = league['matches'][0]['SumScore']
				matchHalfResult[pos] = league['matches'][0]['HalfTimeResult']
				matchFinalResult[pos] = league['matches'][0]['FinalTimeResult']
				matchDate[pos] = league['matches'][0]['Date'].split('T')[0]
				matchHour[pos] = league['matches'][0]['Date'].split('T')[1]

				steack = 0.5
				
				# Verifica se são jogos diferentes
				if(oldMatchId[pos] != newMatchId[pos]):
					oldMatchId[pos] = newMatchId[pos]
		except Exception: 
			print(Exception)
            		
