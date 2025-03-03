#Questão 5

#Função para inverter string
def inverter_string(s):
    if not s.strip():  # Verifica se a string está vazia ou contém apenas espaços
        return "Erro: Nenhuma string válida foi informada."
    return s[::-1] #slicing para percorrer a string de trás para frente.

try:
    string = input("Informe uma string: ")
    print (f"String invertida: {inverter_string(string)}")
except ValueError as e:
    print(e)