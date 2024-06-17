using _001_Static;

NonStaticClass nsc1 = new NonStaticClass(1);
NonStaticClass nsc2 = new NonStaticClass(2);

nsc1.Method();
nsc2.Method();
//На классе объекте NonStaticClass мы обращаемя к статическому полю field
NonStaticClass.field = 3;

nsc1.Method();
nsc2.Method();