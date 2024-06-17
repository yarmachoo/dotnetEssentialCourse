﻿//Упаковка и распаковка

//Упаковка (Boxing) - преобразование структурного типа 
//(типа значения) в ссылочный тип
//(Object или любой другой тип интерфейса, реализуемый этим типом значения).
//Когда тип значения упаковывается средой CLR, она создает программу-оболочку
//значения внутри System.Object и сохраняет ее в управляемой ккуче

//Распаковка (Unboxing) - преобразование ссылочного типа в
//структурный тип. операция распаковки-преобразования извлекает тип значения из объекта
//Перед распаковкой среда выполнения проверяет совместимость между объектом и структурой,
//в которую потом будет происходить распаковка.

short a = 25;

//Упаковка переменной а - (Boxing)
object o = a;

//Распаковка объекта (UnBoxing)
short b = (short)o;

//Распаковка должна проводиться только в тот типа, из которого
//производилась упаковка.
byte s = (byte)o;
//Invalid cast exception

