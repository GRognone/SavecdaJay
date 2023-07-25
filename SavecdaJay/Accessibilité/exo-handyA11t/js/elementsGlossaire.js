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
        this.mesElementsGlossaire = await Db.getData("./glossaire.json");
        this.mesElementsGlossaire = this.mesElementsGlossaire.map(m=>new MesElementsDuGlossaire(m));
    }
}
export{MesElementsDuGlossaire}