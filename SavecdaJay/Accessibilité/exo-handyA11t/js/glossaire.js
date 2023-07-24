class MonGlossaire
{
    constructor(monGlossaire)
    {
        Object.assign (this,monGlossaire);
    }
    getValue()
    {
        return MonGlossaire.value(this);
    }
}
export { MonGlossaire}
