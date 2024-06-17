using _001_Static;

//Вызывается только статический конструктор
NonStaticClass.StaticMethod();

//Вызываются оба конструктора
new NonStaticClass().NonStaticMethod();
