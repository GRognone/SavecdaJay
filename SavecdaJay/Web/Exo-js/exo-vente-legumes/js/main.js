import { VegetablesCollection } from "./vegetablesCollection.js";
import { TableVegetable } from "./tableVegetable.js";



let vegetablesCollection = new VegetablesCollection();


await vegetablesCollection.loadData();

let tableVegetable = new TableVegetable(vegetablesCollection);
tableVegetable.generateTable();
