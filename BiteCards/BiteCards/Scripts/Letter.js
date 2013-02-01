function Letter(id, stopleft) {
    this.id = id;
    this.stopleft = stopleft;
}

Letter.prototype.actionMove = function () {
    this.left = parseFloat($(id).css.left);
    this.top = parseFloat($(id).css.top);
    if (left > stopleft) {
        $(id).css.left = (left - 3);
    }
};