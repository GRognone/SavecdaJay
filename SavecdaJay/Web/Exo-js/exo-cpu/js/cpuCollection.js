import { Processor } from "./processor.js";
import {Db} from "./db.js";

class CpuCollection{

    constructor(){

        this.cpusCollection =[];
        this.sortAsc =true;
    }

    async loadData()
    {
        
        this.cpusCollection = await Db.getDb("./cpu.json");
        this.cpusCollection = this.cpusCollection.map(c=> new Processor(c));
    }

    async searchByName(value)
    {
        await this.loadData();
        value = value.trim();
        if(value.lenght>0);
        {
            value = value.toLowerCase();
            this.cpusCollection = this.cpusCollection.filter(c=>c.name.toLowerCase().includes(value));
        }
    }

    sortByPrice()
    {
        let array = this.cpusCollection.sort((a,b) =>a.price - b.price);
        this.bool=!this.bool;
        if(this.bool){
            return array.reverse();
        }
        return array;
    }

}
export{ CpuCollection }