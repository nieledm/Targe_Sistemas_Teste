#Questão 2

#Função para verificar se está na sequência fibnacci
def is_fibonacci(n):
    #iniciando variáveis
    a, b = 0, 1
    
    #laço para atualizar valores de a e b
    while b < n:
        a, b = b, a + b
    
    #Se b for igual a n, n pertence a sequencia e resposta é true
    return b == n

numero = int(input("Informe um número: "))
if is_fibonacci(numero):
    print("O número ", numero, " pertence à sequência de Fibonacci.")
else:
    print("O número ", numero, "não pertence à sequência de Fibonacci.")