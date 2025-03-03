#Questão 4

#Cadastro de dados, organizados em um dicionário
faturamento_estados = {
    'sp' : 67836.43,
    'rj': 36678.66,
    'mg': 29229.88,
    'es': 27165.48,
    'outros': 19849.53
}

total = sum(faturamento_estados.values())

print("O percentual de representação que cada estado foi:")

#Laço for para impressão das porcentagens das participações
for estado, valor in faturamento_estados.items():
    percentual = (valor / total) * 100
    print (f"{estado}: {percentual:.2f}%")