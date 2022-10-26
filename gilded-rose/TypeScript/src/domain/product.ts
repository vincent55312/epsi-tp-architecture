export class Product {
    name: string;
    numberDayUntilExpirationDate: number;
    qualityFactor: number;

    constructor(name, numberDayUntilExpirationDate, qualityFactor) {
        this.name = name;
        this.numberDayUntilExpirationDate = numberDayUntilExpirationDate;
        this.qualityFactor = qualityFactor;
    }
}