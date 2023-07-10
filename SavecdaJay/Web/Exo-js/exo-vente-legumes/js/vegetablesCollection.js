import{Db} from "./db.js";
import{Vegetable} from "./vegetable.js"

class VegetablesCollection{

    constructor()
    {
        this.initialCollection=[];
        this.modifCollection =[];
    }

    async loadData(){
        console.log(document);
        let temp = await Db.fechData("https://arfp.github.io/tp/web/frontend/grocery/legumos.json");
        this.initialCollection = temp.map(v=>new Vegetable(v));
        this.modifCollection = Array.from(this.initialCollection);
    }

}
export {VegetablesCollection}