import 'package:flutter/material.dart';

void main() {
  runApp(const TarefasPessoaisApp());
}

class TarefasPessoaisApp extends StatelessWidget {
  const TarefasPessoaisApp({super.key});

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'Controle de Tarefas Pessoais',
      theme: ThemeData(
        primarySwatch: Colors.indigo,
        fontFamily: 'RobotoSlab',
      ),
      home: const HomePage(),
      debugShowCheckedModeBanner: false,
    );
  }
}

class HomePage extends StatefulWidget {
  const HomePage({super.key});

  @override
  State<HomePage> createState() => _HomePageState();
}

class _HomePageState extends State<HomePage> {
  final List<String> _tarefas = [];

  void _adicionarTarefa(String tarefa) {
    setState(() {
      _tarefas.add(tarefa);
    });
  }

  void _mostrarDialogAdicionarTarefa() {
    String novaTarefa = '';

    showDialog(
      context: context,
      builder: (context) => AlertDialog(
        title: const Text('Nova Tarefa'),
        content: TextField(
          autofocus: true,
          onChanged: (value) => novaTarefa = value,
          decoration: const InputDecoration(hintText: 'Digite sua tarefa'),
        ),
        actions: [
          TextButton(
            onPressed: () => Navigator.pop(context),
            child: const Text('Cancelar'),
          ),
          ElevatedButton(
            onPressed: () {
              if (novaTarefa.trim().isNotEmpty) {
                _adicionarTarefa(novaTarefa.trim());
              }
              Navigator.pop(context);
            },
            child: const Text('Adicionar'),
          ),
        ],
      ),
    );
  }

  void _mostrarDialogoCreditos() {
    showDialog(
      context: context,
      builder: (context) => AlertDialog(
        title: const Text('Créditos'),
        content: const Text('App desenvolvido por João Victor Pires Novaes e Luiz Felipe Bastião'),
        actions: [
          TextButton(
            onPressed: () => Navigator.pop(context),
            child: const Text('Fechar'),
          ),
        ],
      ),
    );
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('Tarefas Pessoais'),
        actions: const [
          Icon(Icons.task_alt),
          SizedBox(width: 16),
        ],
      ),
      drawer: Drawer(
        child: ListView(
          padding: EdgeInsets.zero,
          children: [
            const DrawerHeader(
              decoration: BoxDecoration(color: Colors.indigo),
              child: Text('Menu', style: TextStyle(color: Colors.white, fontSize: 24)),
            ),
            const ListTile(
              leading: Icon(Icons.home),
              title: Text('Início'),
            ),
            const ListTile(
              leading: Icon(Icons.settings),
              title: Text('Configurações'),
            ),
            ListTile(
              leading: const Icon(Icons.people),
              title: const Text('Créditos'),
              onTap: _mostrarDialogoCreditos,
            ),
          ],
        ),
      ),
      body: _tarefas.isEmpty
          ? Center(
              child: Column(
                mainAxisAlignment: MainAxisAlignment.center,
                children: [
                  Image.asset(
                    'assets/logo.jpg',
                    width: 150,
                    height: 150,
                  ),
                  const SizedBox(height: 20),
                  const Text('Nenhuma tarefa adicionada.'),
                ],
              ),
            )
          : ListView.builder(
              itemCount: _tarefas.length,
              itemBuilder: (context, index) => ListTile(
                leading: const Icon(Icons.check_box_outline_blank),
                title: Text(_tarefas[index]),
              ),
            ),
      floatingActionButton: FloatingActionButton(
        onPressed: _mostrarDialogAdicionarTarefa,
        backgroundColor: Colors.indigo,
        child: const Icon(Icons.add),
      ),
    );
  }
}
