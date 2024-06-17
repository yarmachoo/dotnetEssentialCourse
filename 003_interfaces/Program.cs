using _003_interfaces;

DerivedClass instance = new DerivedClass();

//instance.Method();
//Для Экземпляра DerivedClass метод Method() является private

Interface1 instance1 = instance as  Interface1;
Interface2 instance2 = instance as Interface2;

instance1.Method();
instance2.Method();