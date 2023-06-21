import{Cereales} from "./cereales.js";
import {Table} from "./table.js";

let cereale = new Cereales();
await cereale.getCereales();
console.log(cereale.cerealesCollection);

let cerealeTable = new Table(cereale);
cerealeTable.generateBody();