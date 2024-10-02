const car = {
    name: "Tesla",
    model: "X",
};
function showCarInfo() {
    console.log(`Car name:${this.name},Model:${this.model}`);
}
const boundShowCarInfo = showCarInfo.bind(car);
boundShowCarInfo();