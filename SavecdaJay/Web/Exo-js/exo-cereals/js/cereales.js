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
    sortByvalue()
    {
        //tri du tableau par cereale
        this.cerealesCollection.sort((a , b) => a.cereales_id - b.cereales_id);

        //tri dans l'ordre
        if (!this.sortOrder)
        {
            this.cerealesCollection.reverse();
        }
        //pour inverser l'ordre du tri si l'on re-click sur le bouton de tri
        this.sortOrder = !this.sortOrder;
    }
}
export{Cereales};