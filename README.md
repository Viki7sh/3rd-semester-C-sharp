Лабораторная работа №4


В этой лабе использовались две службы: 

1)`Service2` это служба, разработанная в третьей лабораторной работе.

2)`DataMаnager` это служба, разработанная в данной лабораторной работе. Для разработки этой службы использовалась 
база данных `AdventureWorksLT2019`.

Рассмотрим пошаговую инструкцию к работе:
1. Запускается `DataManager`;
2. После запуска службы `Service2` программа начинается в классе Program и обращаетс к xml & json и изъятие нужной информации;
3. Таблица состоит из пяти отношений: 

  ![Screenshot](screenshot/5.png)

  ![Screenshot](screenshot/2.PNG)
  
  
  
4. Создаётся объект класса `DBApplicationInsights`, который отвечает за логирование. Все действия заносятся в базу данных с помощью 
метода `AddInTable`. 

  ![Screenshot](screenshot/1.PNG)
  
  

5. Хранимые процедуры ClearTable, AddinTable:
  
  ![Screenshot](screenshot/3.PNG)
  
  ![Screenshot](screenshot/4.PNG)
