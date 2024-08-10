#include<stdio.h>
#include<locale.h>
int main()
{
    setlocale(LC_ALL,"Turkish");
    int sec;
    printf("1.mod =  Kurutma ");
    printf("\n2.mod =  Derin Temizleme ");
    printf("\n1.mod =  Renkli ");
    printf("\nLütfen 1 ile 3 arasında bir sayı giriniz :");
    scanf("%d",&sec);
    switch(sec){
    case 1: printf("Kurutma modu seçildi.");break;
    case 2: printf("Derin Temizleme modu seçildi.");break;
    case 3: printf("Renkli modu seçildi.");break;
    default: printf("Lütfen geçerli bir mod seçiniz !");break;
    
    }
    
    return 0;
}
