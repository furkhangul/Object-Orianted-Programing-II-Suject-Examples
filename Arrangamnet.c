#include<stdio.h>
#include<locale.h>
int main()
{
    setlocale(LC_ALL,"Turkish");
    int sayi1;
    int sayi2;
    int sayi3;
   printf("Lütfen ilk sayınızı giriniz:");
   scanf("%d",&sayi1);
   printf("Lütfen ikinci sayınızı giriniz:");
   scanf("%d",&sayi2);
   printf("Lütfen üçüncü sayınızı giriniz:");
   scanf("%d",&sayi3);
    if(sayi1>sayi2&&sayi1>sayi3){
          
          if(sayi2>sayi3){
           printf("%d>%d>%d",sayi1,sayi2,sayi3);
           }
           else{
           printf("%d>%d>%d",sayi1,sayi3,sayi2);
           }
     }
     else if(sayi2>sayi1&&sayi2>sayi3){
            if(sayi1>sayi2){
            printf("%d>%d>%d",sayi2,sayi1,sayi3);
            
            }
            else{
            
            printf("%d>%d>%d",sayi2,sayi3,sayi1);
           }
            }
      
     
     else if (sayi3>sayi1&&sayi3>sayi2){
           if(sayi1>sayi2){
           
           
           printf("%d>%d>%d",sayi3,sayi1,sayi2);
           }
           else{
           
           printf("%d>%d>%d",sayi3,sayi2,sayi1);
           }
           }
    return 0;
}
