using _006_Inheritance;

DerivedClass instance =  new DerivedClass();
instance.Method();

//UpCast
BaseClass instanceUp = instance;
instanceUp.Method();

//Downcast
DerivedClass instanceDown = (DerivedClass)instanceUp;
instanceDown.Method();