import { Db } from "./db.js";
import { Cereal } from "./cereal.js";

class Cereals {
    static updateFilter =()=>[];

    constructor() {
        this.cerealsCollection = [];
        this.filtersData= [];
        this.bool = true;
    }

    async getCereals() {
        let cerealToAdd = await Db.fetchData("https://arfp.github.io/tp/web/frontend/cereals/cereals.json");
        for (let cereal of cerealToAdd.data) {
            this.cerealsCollection.push(new Cereal(cereal));
        }
        this.filtersData = this.cerealsCollection;
        return this.cerealsCollection;
    }
    deleteCereal(id) {
        this.cerealsCollection = this.cerealsCollection.filter(cer => cer.id != id);
    }
    sortCerealById() {
        let array = this.cerealsCollection.sort((a, b) => a.id - b.id);
        this.bool = !this.bool;
        if (this.bool) {
            return array.reverse();
        }
        return array;
    }

    sortCerealByName() {
        let array = this.cerealsCollection.sort((a, b) => a.name.localeCompare(b.name));
        this.bool = !this.bool;
        if (this.bool) {
            return array.reverse();
        }
        return array;
    }
    sortCerealByCalories() {
        let array = this.cerealsCollection.sort((a, b) => a.calories - b.calories);
        this.bool = !this.bool;
        if (this.bool) {
            return array.reverse();
        }
        return array;
    }
    sortCerealByProteins() {
        let array = this.cerealsCollection.sort((a, b) => a.protein - b.protein);
        this.bool = !this.bool;
        if (this.bool) {
            return array.reverse();
        }
        return array;
    }
    sortCerealBySodiums() {
        let array = this.cerealsCollection.sort((a, b) => a.sodium - b.sodium);
        this.bool = !this.bool;
        if (this.bool) {
            return array.reverse();
        }
        return array;
    }
    sortCerealByFibers() {
        let array = this.cerealsCollection.sort((a, b) => a.fiber - b.fiber);
        this.bool = !this.bool;
        if (this.bool) {
            return array.reverse();
        }
        return array;
    }
    sortCerealByCarbos() {
        let array = this.cerealsCollection.sort((a, b) => a.carbo - b.carbo);
        this.bool = !this.bool;
        if (this.bool) {
            return array.reverse();
        }
        return array;
    }
    sortCerealBySugars() {
        console.log("test")
        let array = this.cerealsCollection.sort((a, b) => a.sugars - b.sugars);
        this.bool = !this.bool;
        if (this.bool) {
            return array.reverse();
        }
        return array;
    }

    sortCerealByPotass() {
        console.log("test")
        let array = this.cerealsCollection.sort((a, b) => a.potass - b.potass);
        this.bool = !this.bool;
        if (this.bool) {
            return array.reverse();
        }
        return array;
    }

    sortCerealByVitamins() {
        console.log("test")
        let array = this.cerealsCollection.sort((a, b) => a.vitamins - b.vitamins);
        this.bool = !this.bool;
        if (this.bool) {
            return array.reverse();
        }
        return array;
    }

    sortCerealByRatings() {
        console.log("test")
        let array = this.cerealsCollection.sort((a, b) => a.rating - b.rating);
        this.bool = !this.bool;
        if (this.bool) {
            return array.reverse();
        }
        return array;
    }


//fonctionnnement de tous les filtres 

/*fonction de recherche*/
    searchCereals(value) {
        this.filtersData = this.cerealsCollection.filter(c => c.name.toLowerCase().includes(value.toLowerCase()));
    }

/*tri par catégorie*/
    sortCategory(value) {
        switch (value) {

            case "1":
                this.filtersData = this.filtersData.filter(c => c.sodium<50);
                break;
            case "2":
                this.filtersData = this.filtersData.filter(c => c.sugars<1);
                break;
            case "3":
                this.filtersData = this.filtersData.filter(c => c.vitamins>=25 && c.fiber>=10);
                break;
            default:
                this.filtersData = Array.from(this.filtersData);
                break;
        }

    }
    /* tri par checkBox nutriscore*/

    sortNutriscore(letters){
        
        if(letters.length>0){
            this.filtersData = this.filtersData.filter(c=>letters.includes(c.ns));
        }
        else{
            this.filtersData = Array.from(this.filtersData);
        }
    }

    /* coordination de tous les filtres */
    applyAllFilters(cerealName, cerealCategory, selectedNS)
    {
        this.searchCereals(cerealName);
        this.sortCategory(cerealCategory);
        this.sortNutriscore(selectedNS);
    }
}
export { Cereals };