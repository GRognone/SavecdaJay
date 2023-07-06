import { Cereals } from "./cereals.js";
class CerealEvent
{
    static cereals;
    
    static searchCereals(value)
    {
       return this.cereals.searchCereals(value);
    }
}
export{CerealEvent}