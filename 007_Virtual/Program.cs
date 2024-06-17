using _007_Virtual;

DerivedClass instance = new DerivedClass();
instance.Method();

//UpCast
BaseClass instanceUp = instance;
instanceUp.Method();

//Downcast
DerivedClass instanceDown = (DerivedClass)instanceUp;
instanceDown.Method();