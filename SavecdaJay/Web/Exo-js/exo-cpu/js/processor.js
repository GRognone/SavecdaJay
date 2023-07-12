class Processor {
    constructor(processor) {
        Object.assign(this, processor);
        this.name = this.nameComplet();
    }
    getValue() {
        return Object.values(this);
    }
    nameComplet() {
        let name;
        let brand;
        let family;
        let model;

        name = brand + "" + family + "" + model + "";
        return name;
    }
}
export { Processor }