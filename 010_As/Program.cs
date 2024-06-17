using _010_As;

DerivedClass instance = new DerivedClass();
instance.Method();

//UpCast
BaseClass instanceUp = instance as BaseClass;
instanceUp.Method();

//Downcast
DerivedClass? instanceDown = instanceUp as DerivedClass;
instanceDown?.Method();