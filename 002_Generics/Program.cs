

MyGeneric<string, int> instance = new MyGeneric<string, int>("MyName", 1);


class MyGeneric<TYPE1, TYPE2>
{
    private TYPE1 var1;
    private TYPE2 var2;

    public MyGeneric(TYPE1 arg1, TYPE2 arg2)
    {
        this.var2 = arg2;
        this.var1 = arg1;
    }

    public TYPE1 Var1
    {
        get { return this.var1; }
        set { this.var1 = value; }
    }
    public TYPE2 Var2
    {
        get { return this.var2; }
        set { this.var2 = value; }
    }
}