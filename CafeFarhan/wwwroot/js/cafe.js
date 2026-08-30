let cart = [];


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

    updateCart();

}


function updateCart() {

    const count =
        cart.reduce(
            (sum, item) => sum + item.quantity,
            0
        );

    document.getElementById("cart-count")
        .innerText = count;


    const container =
        document.getElementById("cart-items");

    container.innerHTML = "";


    let total = 0;


    cart.forEach(item => {

        const itemTotal =
            item.price * item.quantity;

        total += itemTotal;


        container.innerHTML += `

            <div class="cart-item">

                <div>
                    <strong>
                        ${item.name}
                    </strong>

                    <div>
                        ${item.quantity} ×
                        ${item.price.toLocaleString()}
                    </div>
                </div>

                <strong>
                    ${itemTotal.toLocaleString()}
                    تومان
                </strong>

            </div>

        `;

    });


    document.getElementById("cart-total")
        .innerText =
        total.toLocaleString() + " تومان";
}


function openCart() {

    document
        .getElementById("cart-modal")
        .classList.add("active");

}


function closeCart() {

    document
        .getElementById("cart-modal")
        .classList.remove("active");

}


function checkout() {

    if (cart.length === 0) {

        alert("سبد خرید خالی است");

        return;
    }

    const table =
        new URLSearchParams(
            window.location.search
        ).get("table");

    if (!table) {

        alert("شماره میز مشخص نیست");

        return;
    }


    fetch("/Order/Create", {

        method: "POST",

        headers: {
            "Content-Type":
                "application/json"
        },

        body: JSON.stringify({

            tableNumber: parseInt(table),

            items: cart.map(x => ({

                productId: x.id,

                quantity: x.quantity

            }))

        })

    })
        .then(response => {

            if (!response.ok)
                throw new Error();

            return response.json();

        })
        .then(data => {

            alert(
                "سفارش شما با موفقیت ثبت شد.\n" +
                "شماره سفارش: " +
                data.orderId
            );

            cart = [];

            updateCart();

            closeCart();

        })
        .catch(() => {

            alert(
                "ثبت سفارش با خطا مواجه شد."
            );

        });

}