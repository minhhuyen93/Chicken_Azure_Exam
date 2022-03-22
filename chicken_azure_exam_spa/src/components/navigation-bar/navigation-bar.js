import { Link } from 'react-router-dom';
import './navigation-bar.css';
function NavigationBar() {
    return (
        <div className="navigation-bar" >
            <h2><Link to="/products">Product List</Link></h2>
            <h2><Link to="/products/create">Create</Link></h2>
        </div>
    );
}

export default NavigationBar;