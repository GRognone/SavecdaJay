import { Cereals } from "./cereals.js";
class CerealEvent
{
    static cereals;
    
    static searchCereals(value)
    {
       return this.cereals.searchCereals(value);
    }

    // static columnSortEvent(e){

    //     let attributeName = e.target.dataset.name;
    //     let firstCollectionItem =  CerealEvent.cerealsCollection.data[0];

    //     if(typeof(firstCollectionItem[attributeName]) != "string") {
    //         CerealEvent.cerealsCollection.data.sort((x,y) => x[e.target.dataset.name] - y[e.target.dataset.name]);

    //         CerealEvent.cerealsCollection.data.sort(function (x,y) { return x[attributeName] - y[attributeName] });
    //     }
    //     else{
    //         CerealEvent.cerealsCollection.data.sort((x,y)=>x[attributeName].localeCompare(y[attributeName]));
    //     }
    //     if(CerealEvent.sortDirection){
    //         CerealEvent.cerealsCollection.data.reverse();
    //     }
    //     CerealEvent.sortDirection=!CerealEvent.sortDirection;
    // }
}

export{CerealEvent}