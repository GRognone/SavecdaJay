class Vegetable{

    constructor(vegetable)
    {
        Object.assign(this, vegetable)
    }

    getValues()
    {
        return Object.values(this);
    }
}
export{Vegetable}