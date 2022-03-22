import './product-list.css';

function ProductList() {
    return (
        <div>
            <h1 style={{ textAlign: "center" }}>Welcome to the Chicken_Azure_Exam Project</h1>
            <section className="products">
                <div className="product-card">
                    <div className class="product-image">
                        <img alt='no alt' src='https://miro.medium.com/max/1200/1*UGCW33jtXD0ntGHu907uYQ.png' />
                    </div>
                    <div class="product-info">
                        <h4>Product Name</h4>
                        <h5>Product Prize</h5>
                        <button class="app-btn" >Add to <i className="fa fa-shopping-cart" aria-hidden="true"></i></button>
                    </div>
                </div>
                <div className="product-card">
                    <div className class="product-image">
                        <img alt='no alt' src='https://miro.medium.com/max/1200/1*UGCW33jtXD0ntGHu907uYQ.png' />
                    </div>
                    <div class="product-info">
                        <h4>Product Name</h4>
                        <h5>Product Prize</h5>
                        <button class="app-btn" >Add to <i className="fa fa-shopping-cart" aria-hidden="true"></i></button>
                    </div>
                </div>
                <div className="product-card">
                    <div className class="product-image">
                        <img alt='no alt' src='https://miro.medium.com/max/1200/1*UGCW33jtXD0ntGHu907uYQ.png' />
                    </div>
                    <div class="product-info">
                        <h4>Product Name</h4>
                        <h5>Product Prize</h5>
                        <button class="app-btn" >Add to <i className="fa fa-shopping-cart" aria-hidden="true"></i></button>
                    </div>
                </div>
                <div className="product-card">
                    <div className class="product-image">
                        <img alt='no alt' src='https://miro.medium.com/max/1200/1*UGCW33jtXD0ntGHu907uYQ.png' />
                    </div>
                    <div class="product-info">
                        <h4>Product Name</h4>
                        <h5>Product Prize</h5>
                        <button class="app-btn" >Add to <i className="fa fa-shopping-cart" aria-hidden="true"></i></button>
                    </div>
                </div>
                <div className="product-card">
                    <div className class="product-image">
                        <img alt='no alt' src='https://miro.medium.com/max/1200/1*UGCW33jtXD0ntGHu907uYQ.png' />
                    </div>
                    <div class="product-info">
                        <h4>Product Name</h4>
                        <h5>Product Prize</h5>
                        <button class="app-btn" >Add to <i className="fa fa-shopping-cart" aria-hidden="true"></i></button>
                    </div>
                </div>
            </section >
        </div >
    );
}

export default ProductList;