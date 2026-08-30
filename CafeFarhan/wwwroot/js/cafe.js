let cart = [];


// ================================
// ADD TO CART
// ================================
function addToCart(id, name, price) {

    const existing = cart.find(x => x.id === id);

    if (existing) {

        existing.quantity++;

    } else {

        cart.push({
            id: id,
            name: name,
            price: price,
            quantity: 1
        });

    }

    saveCart();
    updateCart();
}


// ================================
// INCREASE QUANTITY
// ================================
function increaseQuantity(id) {

    const item = cart.find(x => x.id === id);

    if (!item)
        return;

    item.quantity++;

    saveCart();
    updateCart();
}


// ================================
// DECREASE QUANTITY
// ================================
function decreaseQuantity(id) {

    const item = cart.find(x => x.id === id);

    if (!item)
        return;

    item.quantity--;

    if (item.quantity <= 0) {

        cart = cart.filter(x => x.id !== id);

    }

    saveCart();
    updateCart();
}


// ================================
// REMOVE ITEM
// ================================
function removeFromCart(id) {

    cart = cart.filter(x => x.id !== id);

    saveCart();
    updateCart();
}


// ================================
// UPDATE CART UI
// ================================
function updateCart() {

    const count = cart.reduce(
        (sum, item) => sum + item.quantity,
        0
    );


    const cartCount =
        document.getElementById("cart-count");

    if (cartCount) {

        cartCount.innerText = count;

    }


    const container =
        document.getElementById("cart-items");

    if (!container)
        return;


    container.innerHTML = "";

    let total = 0;


    if (cart.length === 0) {

        container.innerHTML = `
            <div class="empty-cart">
                سبد خرید خالی است
            </div>
        `;

    }


    cart.forEach(item => {

        const itemTotal =
            item.price * item.quantity;

        total += itemTotal;


        container.innerHTML += `

            <div class="cart-item">

                <div class="cart-item-info">

                    <strong>
                        ${item.name}
                    </strong>

                    <div class="cart-price">
                        ${item.price.toLocaleString()}
                        تومان
                    </div>

                </div>


                <div class="cart-item-actions">

                    <button
                        type="button"
                        onclick="increaseQuantity(${item.id})">
                        +
                    </button>


                    <span>
                        ${item.quantity}
                    </span>


                    <button
                        type="button"
                        onclick="decreaseQuantity(${item.id})">
                        −
                    </button>

                </div>


                <div class="cart-item-total">

                    ${itemTotal.toLocaleString()}
                    تومان

                </div>


                <button
                    type="button"
                    class="remove-item"
                    onclick="removeFromCart(${item.id})">

                    ×

                </button>

            </div>

        `;

    });


    const totalElement =
        document.getElementById("cart-total");


    if (totalElement) {

        totalElement.innerText =
            total.toLocaleString() + " تومان";

    }
}


// ================================
// OPEN CART
// ================================
function openCart() {

    document
        .getElementById("cart-modal")
        .classList.add("active");

}


// ================================
// CLOSE CART
// ================================
function closeCart() {

    document
        .getElementById("cart-modal")
        .classList.remove("active");

}


// ================================
// SAVE CART
// ================================
function saveCart() {

    localStorage.setItem(
        "cafeCart",
        JSON.stringify(cart)
    );

}


// ================================
// LOAD CART
// ================================
function loadCart() {

    const savedCart =
        localStorage.getItem("cafeCart");


    if (savedCart) {

        try {

            cart = JSON.parse(savedCart);

        } catch {

            cart = [];

        }

    }


    updateCart();
}


// ================================
// GET TABLE NUMBER
// ================================
function getTableNumber() {

    const params =
        new URLSearchParams(
            window.location.search
        );

    const table =
        params.get("table");


    if (!table)
        return null;


    const tableNumber =
        parseInt(table);


    if (
        isNaN(tableNumber) ||
        tableNumber <= 0
    ) {

        return null;

    }


    return tableNumber;
}


// ================================
// SUBMIT ORDER
// ================================
async function submitOrder() {

    if (cart.length === 0) {

        alert("سبد خرید خالی است");

        return;

    }


    const tableNumber =
        getTableNumber();


    if (!tableNumber) {

        alert(
            "شماره میز مشخص نیست."
        );

        return;

    }


    const orderItems =
        cart.map(item => ({

            productId: item.id,

            quantity: item.quantity

        }));


    try {

        const response =
            await fetch(
                "/Order/Create",
                {

                    method: "POST",

                    headers: {

                        "Content-Type":
                            "application/json"

                    },

                    body: JSON.stringify({

                        tableNumber:
                            tableNumber,

                        items:
                            orderItems

                    })

                }
            );


        if (!response.ok) {

            throw new Error(
                "Request failed"
            );

        }


        const result =
            await response.json();


        if (!result.success) {

            alert(
                result.message ||
                "ثبت سفارش انجام نشد."
            );

            return;

        }


        alert(
            `سفارش شما با شماره #${result.orderId} ثبت شد.`
        );


        // Clear cart

        cart = [];

        localStorage.removeItem(
            "cafeCart"
        );


        updateCart();

        closeCart();


    } catch (error) {

        console.error(error);

        alert(
            "در ثبت سفارش خطایی رخ داد."
        );

    }

}


// ================================
// INITIALIZE
// ================================
document.addEventListener(
    "DOMContentLoaded",
    function () {

        loadCart();

    }
);