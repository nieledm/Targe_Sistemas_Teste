import json

# Carregando os dados do JSON
with open('dados.json', 'r') as file:
    dados = json.load(file)

# Filtrando dias com faturamento maior que zero
faturamento_diario = [dia['valor'] for dia in dados if dia['valor'] > 0]

# Calculando o menor e o maior valor de faturamento
menor_faturamento = min(faturamento_diario)
maior_faturamento = max(faturamento_diario)

# Calculando a média mensal
media_mensal = sum(faturamento_diario) / len(faturamento_diario)

# Contando dias com faturamento acima da média
dias_acima_da_media = sum(1 for valor in faturamento_diario if valor > media_mensal)

print(f"Menor faturamento: R$ {menor_faturamento:.2f}")
print(f"Maior faturamento: R$ {maior_faturamento:.2f}")
print("Dias com faturamento acima da média: ", dias_acima_da_media)