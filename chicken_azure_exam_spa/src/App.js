import { BrowserRouter, Routes, Route } from 'react-router-dom';

import './App.css';
import NavigationBar from './components/navigation-bar/navigation-bar';
import ProductCreate from './components/product-create/product-create';
import ProductList from './components/product-list/product-list';

function App() {
  return (
    <BrowserRouter>
      <NavigationBar />
      <div className="container" style={{ padding: "20px" }}>
        <Routes>
          <Route path="/" element={<h1>Product list</h1>} />
          <Route path="products" element={<ProductList />} />
          <Route path="/products/create" element={<ProductCreate />} />
          <Route path="*" element={<h1>Not Found</h1>} />
        </Routes>
      </div>
    </BrowserRouter>
  );
}

export default App;
