package com.example.demo.Controller;

import com.example.demo.Entity.Cargo;
import com.example.demo.Entity.Customer;
import com.example.demo.Entity.Employee;
import com.example.demo.Entity.Shipment;
import com.example.demo.repository.BranchRepository;
import com.example.demo.repository.CargoRepository;
import com.example.demo.repository.CustomerRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;

import java.util.List;

@Controller
@RequestMapping("/Cargo")
public class CargoTrackController {
    CargoRepository cargoRepository;
  //  CustomerRepository customerRepository;
    @Autowired
    public CargoTrackController(CargoRepository cargoRepository, CustomerRepository customerRepository) {
        this.cargoRepository = cargoRepository;
        //this.customerRepository = customerRepository;
    }
    @GetMapping
    public String showPage(){
        return "searchCargo";
    }

    @GetMapping("/Track")
    public String search(@RequestParam("cargo_Id") String cargo_ID, Model model){
//        List<Cargotrack> Track= cargoTrackService.TrackShipmentByID(Long.parseLong(cargo_ID));
        Cargo cargo = cargoRepository.findCargoByCID(Long.parseLong(cargo_ID));
//        Customer cus =cargo.getCargoCustomer();
//        cus.setName("Burak Bahir Günden");
//        customerRepository.save(cus);
        //cargoRepository.save(cargo);
        if(cargo==null){
            return "searchCargo";
        }
        List<Shipment> Track=cargo.getCargoBranch();
//        Employee emp = employeeService.getById(Long.parseLong(search));
        model.addAttribute("track",Track);
        model.addAttribute("CargoInfo",cargo);
//        model.addAttribute("Customer",cargo.getCargoCustomer());
        return "cargoTrack";
    }

}






/*package com.example.demo.Controller;

import com.example.demo.Entity.Cargotrack;
import com.example.demo.Entity.Employee;
import com.example.demo.service.CargoTrackService;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestParam;

import java.util.List;

@Controller
public class CargoTrackController {
    CargoTrackService cargoTrackService;

    public CargoTrackController(CargoTrackService cargoTrackService) {
        this.cargoTrackService = cargoTrackService;
    }
    @GetMapping("/Track")
    public String search(@RequestParam("cargo_Id") String cargo_ID, Model model){
        List<Cargotrack> Track= cargoTrackService.TrackShipmentByID(Long.parseLong(cargo_ID));

//        Employee emp = employeeService.getById(Long.parseLong(search));
        model.addAttribute("track",Track);
        return "cargoTrack";
    }

}
*/