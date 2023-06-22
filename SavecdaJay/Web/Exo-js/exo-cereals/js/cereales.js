import {Db} from "./db.js";
import { Cereale } from "./cereale.js";

class Cereales{

    constructor()
    {
        this.cerealesCollection = [];
    }

    async getCereales()
    {
        let cerealeToAdd = await Db.fetchData("https://arfp.github.io/tp/web/frontend/cereals/cereals.json");
        for(let cereale of cerealeToAdd.data)
        {
            this.cerealesCollection.push(new Cereale(cereale));
        }
        return this.cerealesCollection;
    }
    deleteCereale(id)
    {
        this.cerealesCollection = this.cerealesCollection.filter(cer => cer.id!=id);
    }
    
}
export{Cereales};