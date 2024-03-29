import { useState } from 'react'
import reactLogo from './assets/react.svg'
import mojLogo from '/vite.svg'
import 'bootstrap/dist/css/bootstrap.min.css'
import './App.css'
import NavBar from './components/NavBar'
import { Route, Routes } from 'react-router-dom'
import { RoutesNames } from './constants'
import Pocetna from './pages/Pocetna'
import Smjerovi from './pages/smjerovi/Smjerovi'
import SmjeroviDodaj from './pages/smjerovi/SmjeroviDodaj'
import SmjeroviPromjena from './pages/smjerovi/SmjeroviPromjena'

function App() {


  return (
    <>
      <NavBar />
      <Routes>
        <Route path={RoutesNames.HOME} element={<Pocetna />} />

        <Route path={RoutesNames.SMJER_PREGLED} element={<Smjerovi />} />
        <Route path={RoutesNames.SMJER_NOVI} element={<SmjeroviDodaj />} />
        <Route path={RoutesNames.SMJER_PROMJENI} element={<SmjeroviPromjena />} />
        
      </Routes>
    </>
  )
}

export default App
