import { Db } from "./db.js";
import { MonGlossaire }from "./glossaire.js";
class MesElementsDuGlossaire
{
    constructor()
    {
        this.mesElementsGlossaire =[];
    }

    async loadData()
    {
        this.mesElementsGlossaire = await Db.getData("./json/glossaire.json");
        this.mesElementsGlossaire = this.mesElementsGlossaire.glossaire.map(m=>new MonGlossaire(m));
    }
}
export{MesElementsDuGlossaire}