
import './App.css';
import Header from './components/Header';
import Footer from './components/Footer';
import Carousel from './components/Carousel';
import CardHome from './components/Cards/CardHome';


function App(){
  return (
    <div className="App">
      <Header/>
      <Carousel/>
      <CardHome/>
      <Footer/>
    </div>
  )

}
export default App;