package com.example.demo.Controller;

import com.example.demo.Entity.Employee;
import com.example.demo.service.EmployeeService;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@Controller
//@RequestMapping("/employees")
public class EmployeeWebController {

    EmployeeService employeeService;

    public EmployeeWebController(EmployeeService employeeService) {
        this.employeeService = employeeService;
    }

    @GetMapping("/employees")
    public String getEmployess(Model model) {
       List<Employee> employees= employeeService.AllEmployess();
       model.addAttribute("employees",employees);
        return "employees";
//        return a.findAll();
    }
    @GetMapping("/employee")
    public String getEmployeeID(Model model){
            String employee=null;
            model.addAttribute("Id",employee);
        return "index.html";
    }
    @PostMapping("/employee")
    public String showEmployee(@ModelAttribute(value = "Id") String employee, Model model){
        model.addAttribute("Id",employee);
        Employee emp = employeeService.getById(Long.parseLong(employee));
        model.addAttribute("empl",emp);

        return "result";
    }

//    @PostMapping()
//    public String updateEmployee(@ModelAttribute String Id, Model model){
//        model.addAttribute("ID",Id);
//        Employee emp = employeeService.getById(Integer.parseInt(Id));
//        model.addAttribute("employee",emp);
//        return "employees";
//    }

//    @GetMapping("/employee2")
//    public String goToSearch(){
//        System.out.println("going to search page");
//        return "employee2";
//    }

    @GetMapping("/employee2")
    public String search(@RequestParam("search") String search, Model model){
//        System.out.println("in search controller");
//        System.out.println("search criteria: "+search);

        Employee emp = employeeService.getById(Long.parseLong(search));
        model.addAttribute("empl",emp);
        return "employee2";
    }



}
