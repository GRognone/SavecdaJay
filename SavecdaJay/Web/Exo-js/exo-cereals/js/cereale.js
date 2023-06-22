class Cereale
{
constructor(cereale)
{
    Object.assign(this,cereale);
    this.ns=this.attributeNutriScore();
}

attributeNutriScore()
{
    if (this.rating>80)
    {
        return "A";
    }
    else if(this.rating>70)
    {
        return "B";
    }
    else if(this.rating>55)
    {
        return "C";
    }
    else if(this.rating>=35)
    {
        return "D";
    }
    else
    {
        return "E";
    }
}



}
export{Cereale};