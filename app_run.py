list_isbn = []
list_nombres = []
list_ejemplares = []
list_pub = []
list_autor = []

import os

def registra_libro(isbn,nombre,autor,pub):
    if isbn == "" or nombre == "" or pub == "" or autor == "":
        enter = input('Enter the entire information <ENTER>')
    else:
        list_isbn.append(isbn)
        list_nombres.append(nombre)
        list_ejemplares.append(0)
        list_pub.append(pub)
        list_autor.append(autor)
        enter = input('Ejemplar registrado con exito <ENTER>')
        
def inventario_libro(isbn):
    if isbn == "":
        enter = input('Debe ingresar el criterio con exito <ENTER>')
    else:
        sw = False
        for i in range(len(list_isbn)):
            if (list_isbn[i]== isbn):
                sw = True 
                pos = i
                break
        if sw == False:
            enter = input('No se encontraron <ENTER>')
        else:
            print('Nombre del libro: ',list_nombres[pos] )
            print('Nombre del autor: ',list_autor[pos] )
            print('Publicacion: ',list_pub[pos] )
            e = int(input('Cantidad de ejemplares: '))
            list_ejemplares[pos] = list_ejemplares[pos] + e
            print('\nInventario libro ', list_nombres[pos], 'Registrado con exito <ENTER>')
            enter = input()
def informe():
    os.system('cls')
    print("-----INFORME-----\n")
    print('Codigo             Nombre                               Autor              Publicacion           Ejemplares')
    for i in range(len(list_isbn)):
        print(list_isbn[i],'              ',list_nombres[i],'                   ',list_autor[i],'            ',list_pub[i],'           ',list_ejemplares[i] )
    enter = input('\n Fin del informe <ENTER>')         


def fnt_menu (inicia):
    while inicia == True :
        os.system('cls')
        m = input("-----MENU PRINCIPAL-----\n\n1.Registra libro\n2.Registro de inventario\n3.Informe\n4.Salir\n\n->")
        if m == '1':
             os.system('cls')
             print('-----Registro de ejemplares-----\n')
             i = input('ISBN: ')
             n = input('Nombre del libro: ')
             a = input('Autor del libro: ')
             p = input('Publicacion: ')
             registra_libro(i,n,a,p)
        if m == '2':   
            os.system('cls') 
            print('-----Registro de inventario-----\n')
            isbn = input('Ingrese el ISBN del libro: ') 
            inventario_libro(isbn)
        if m == '3':
            informe()


fnt_menu(True)

