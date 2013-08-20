function onCheckForMozillaClick() {
    var browserName = window.navigator.appCodeName;
    
    if (browserName === "Mozilla") {
        alert("Yes, this is Mozilla");
    } else {
        alert("No, it's not Mozilla");
    }
}
