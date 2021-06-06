package com.example.demo.service;

import com.example.demo.Entity.Employee;
import com.example.demo.repository.EmployeeRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.ArrayList;
import java.util.List;

@Service
public class EmployeeService {
    private final EmployeeRepository employeeRepository;

    @Autowired
    public EmployeeService(EmployeeRepository employeeRepository) {
        this.employeeRepository = employeeRepository;
    }

    public List<Employee> AllEmployess() {
        Iterable<Employee> employees = this.employeeRepository.findAll();
        List<Employee> employeeList = new ArrayList<>();
        employees.forEach(employee ->
                employeeList.add(employee));
        return employeeList;
    }
    public Employee getById(long ID){
        Iterable<Employee> employees = this.employeeRepository.findEmployeeByID(ID);
        List<Employee> employeeList = new ArrayList<>();
        employees.forEach(employee ->
                employeeList.add(employee));
        if(employeeList.size()==0)
            return null;
        return employeeList.get(0);
    }
    public void updateEmployee(Employee emp, int ID){
        Employee employee = getById(ID);
        employee.setLocation(emp.getLocation());
        employee.setMobilePhone(emp.getMobilePhone());


    }



}
