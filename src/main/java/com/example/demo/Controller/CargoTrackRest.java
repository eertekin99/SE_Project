//package com.example.demo.Controller;
//
//import com.example.demo.Entity.Cargotrack;
//import com.example.demo.Entity.Employee;
//import com.example.demo.repository.CargoTrackRepository;
//import com.example.demo.service.CargoTrackService;
//import org.springframework.web.bind.annotation.GetMapping;
//import org.springframework.web.bind.annotation.RestController;
//
//import java.util.List;
//
//@RestController
//public class CargoTrackRest {
//    CargoTrackRepository repo;
//
//    public CargoTrackRest(CargoTrackRepository repo) {
//        this.repo = repo;
//    }
//    @GetMapping("/TrackCargo")
//    public List<Cargotrack> getTracks() {
//        return repo.findAll();
////        return a.findAll();
//    }
//}
