package com.example.demo.Controller;

import com.example.demo.Entity.Cargo;
//import com.example.demo.Entity.Cargotrack;
import com.example.demo.Entity.Employee;
import com.example.demo.repository.CargoRepository;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RestController;

import java.util.Date;
import java.util.List;

@RestController
public class CargoRestController {
    CargoRepository cargoRepository;

    public CargoRestController(CargoRepository cargoRepository) {
        this.cargoRepository = cargoRepository;
    }
    @GetMapping("/Cargos")
    public List<Cargo> getTracks() {
        return cargoRepository.findAll();
//        return a.findAll();
    }
    @GetMapping("/Cargos/{id}")
    public Date getCargobyId (@PathVariable("id") Long id) {
//        List<Cargo> employee = cargoRepository.findCargoByCID(id);
        Cargo cargo =  cargoRepository.findCargoByCID(id);
        return  cargo.getCargoBranch().get(0).getReceived();

    }
}
