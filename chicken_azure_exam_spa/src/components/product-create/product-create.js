import './product-create.css';

function ProductCreate() {
    return (
        <div className="wrapper">
            <form>
                <label>Product Name: </label>
                <input name="name" type="text" />

                <label>Product Price: </label>
                <input name="price" type="number" />

                <label>Product Image Url: </label>
                <input name="imgUrl" type="text" />
                <label className="form-label" for="customFile">or Upload an image</label>
                <input type="file" className="form-control" id="customFile" />
                <button className="app-btn" type="submit">Submit</button>
            </form>
        </div>
    );
}

export default ProductCreate;