const convert = function (bytes) {
    const megabytes = (bytes / (1024 * 1024)).toFixed(2);
    return `${megabytes} Mb`
}
const result = convert.call(null, 10000)
console.log(result);